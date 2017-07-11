function initializeTable() {
// Attach event listeners to Create
    $('#createLink').click(addCountry);

    createCountry('Bulgaria', 'Sofia');
    createCountry('Germany', 'Berlin');
    createCountry('Russia', 'Moscow');


    function fixLinks() {
        $('tr a').show();
        $('tr:last-child a:contains(Down)').hide();
        $('tr:eq(2) a:contains(Up)').hide();
    }

// Read input and call create row
    function addCountry() {
        let name = $('#newCountryText').val();
        let capital = $('#newCapitalText').val();
        createCountry(name, capital);
        fixLinks();
    }

// Create table row
    function createCountry(name, capital) {
        $('<tr>')
            .append($(`<td>${name}</td>`))
            .append($(`<td>${country}</td>`))
            .append($(`<td>(todo)</td>`))
            .append($('<a href="#">[Up]</a>').click(moveUp))
            .append($('<a href="#">[Down]</a>').click(moveDown))
            .append($('<a href="#">[Delete]</a>').click(deleteRow))
            .appendTo($('#countriesTable'));
    }

    function moveUp() {
        let currentRow = $(this).parent().parent();
        currentRow.insertBefore(currentRow.prev());
        fixLinks();
    }

    function moveDown() {
        let currentRow = $(this).parent().parent();
        currentRow.insertAfter(currentRow.next());
        fixLinks();
    }

    function deleteRow() {
        let currentRow = $(this).parent().parent().remove();
        fixLinks();
    }
}