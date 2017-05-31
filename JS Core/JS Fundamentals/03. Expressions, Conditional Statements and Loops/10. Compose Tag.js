function composesHtmlTag(input) {
    let fileLocation = input[0];
    let alternateText = input[1];

    let html = `<img src="`;
    html += fileLocation;
    html += `" alt="`;
    html += alternateText;
    html += `">`;

    console.log(html);
}