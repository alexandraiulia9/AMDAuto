$('#addNewCategory').on("click", function () {
    var catName = $('#CategoryName').val();
    $.post(Router.action("Admin", "AddCategory"), { catName: catName })
        .done(function () {
            location.reload();
        })
        .fail(function () {
            alert("Eroare!")
        });
})