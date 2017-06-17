function solve() {
    let pattern = /([A-Za-z]+)([\d]+)(?=\s)/g;
    let text = 'Word98 StringFtf23 ';
    text = text.replace(pattern, replacer);
    return text;

    function replacer(match, grp1, grp2) {
        return grp2 + grp1;
    }
}

console.log(solve());