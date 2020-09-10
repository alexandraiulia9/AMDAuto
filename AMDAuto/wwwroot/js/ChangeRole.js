$(document).ready(function () {
    $('.dropdownRoles').hide();
    $('.changeRole').on("click", function (e) {
        let $target = $(e.target);
        let id = $target.data('user-id');
        $(`select[data-user-id=${id}]:eq(0)`).show();
        $(`button[data-user-id=${id}]:eq(0)`).hide();
        $('.dropdownRoles').on("change", function (e) {
            let $target = $(e.target);
            let id = $target.data('user-id');
            let value = $target[0].value;
            console.log("Rolul este "+ $target[0].value);
            if (confirm('Sigur doriti sa schimbati rolul?')) {
                $.post(Router.action("Admin", "SetRoleByUserId"), { userId: id, roleName: value })
                    .done(function () {
                        location.reload();
                    })
                    .fail(function () {
                        alert("Eroare!");
                    });
            }
        });
    });
});
