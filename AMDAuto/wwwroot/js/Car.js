$('#MakeNameId').on("change", function () {
    var makeId = $('#MakeNameId').val();
    $.get(Router.action("Model", "GetModelByMakeId"), { makeId: makeId })
        .done(manageDropdown)
        .fail(function () {
            alert("Eroare!");
        });
})


function manageDropdown(result) {
    var options = '';
    $('#ModelDropDown').empty();
    for (let i = 0; i < result.length; i++) {
        options += '<option value= "' + result[i].id + '">' + result[i].name + '</option>';
    }

    $('#ModelDropDown').append(options);

}