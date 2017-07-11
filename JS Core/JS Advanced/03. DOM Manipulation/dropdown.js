function addItem() {
    let menu = document.getElementById('menu');
    let itemText = document.getElementById('newItemText').textContent;
    menu.textContent = itemText;
    let itemValue = document.getElementById('newItemValue').value;
    menu.value = itemValue;
}
