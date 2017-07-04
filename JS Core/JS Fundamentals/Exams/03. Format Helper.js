function solve(inputArr) {
    let text = inputArr[0];
    text = text
        .replace(/[.,?!:;]\s*/g, (match) => match.trim() + " ")
        .replace(/\s+[.,?!:;]/g, (match) => match.trim())
        .replace(/\.\s*\.\s*\.\s*\!/g, "...!")
        .replace(/(\.\s+)(\d+)/g, (match, grp1, grp2) => grp1.trim() + grp2)
        .replace(/\"(\s*[^\"]+\s*)\"/g, (match, grp1) => `"${grp1.trim()}"`);

    console.log(text);
}

solve(`Terribly formatted text . With chaotic spacings." Terrible quoting "! 
        Also this date is pretty confusing : 20 . 12. 16 .`);