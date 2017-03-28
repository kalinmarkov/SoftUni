const Article = require('mongoose').model('Article');

module.exports = {
    createGet: (req, res) => {
        res.render('article/create');
    },
    createPost: (req, res) => {
        let articleParts = req.body;

        let errorMsg = '';

        if (!req.isAuthenticated()){
            errorMsg = 'Sorry, you must be logged in!';
        } else if (!articleParts.title) {
            errorMsg = 'Title is required!';
        } else if (!articleParts.content) {
            errorMsg = 'Content is required!';
        }

        if (errorMsg) {
            res.render('article/create', { error: errorMsg });
            return;
        }


        articleParts.author = req.user.id;
        Article.create(articleParts).then(article => {
            req.user.articles.push(article.id);
            req.user.save(err => {
                if (err){
                    res.redirect('/', {error: err.message});
                } else {
                    res.redirect('/');
                }
            });
        })
    },

    details: (req, res) => {
        let id = req.params.id;

        Article.findById(id).populate('author').then(article => {
            res.render('article/details', article)
        });
    }
};