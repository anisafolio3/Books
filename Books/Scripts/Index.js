$(document).on('click', '#btnAddPage', function (x) {
    $.get($(this).attr('url'), function (data) {
        //update page count
        var lblNoofPages = $("#lblNoofPages");
        var pageCount = lblNoofPages.text() == "" ? 0 : parseInt(lblNoofPages.text());
        lblNoofPages.text(pageCount + 1);

        data = data.replace('name="PageNo"', 'name="Pages[' + pageCount + '].PageNo"')
            .replace('name="Title"', 'name="Pages[' + pageCount + '].Title"')
            .replace('name="Description"', 'name="Pages[' + pageCount + '].Description"')
        $("#dvPages").append(data);
    });
});