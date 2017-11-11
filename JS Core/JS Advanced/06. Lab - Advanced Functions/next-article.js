function getArticleGenerator(articles) {
    let articleToPrint = Object.assign([], articles);
    return function () {
        if (articleToPrint.length > 0) {
            let article = $('<article>');
            article.append($(`<p>${articleToPrint.shift()}</p>`));
            $('#content').append(article);
        }
    }
}