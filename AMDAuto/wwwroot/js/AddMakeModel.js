$('#addNewMake').on("click", function () {
    var makeName = $('#MakeName').val();
    $.post(Router.action("Admin", "AddMake"), { makeName: makeName })
        .done(function () {
            location.reload();
        })
        .fail(function () {
            alert("Eroare!")
        });
})

