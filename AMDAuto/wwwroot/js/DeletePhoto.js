$('.DeletePhoto').on("click", function (e) {
    let $target = $(e.target);
    let id = $target.data('delete-photo');
    alert(id);
    $.post(Router.action("Gallery", "DeletePhoto", { id: id }))
        .done(function () {
            location.reload();
        })
        .fail(function () {
            alert("Nu s-a putut șterge poza!")
        });
});