$(document).ready(function () {
    $('#submitPhoto').on("click", function () {
        var photo = $('#postPhoto')[0].files[0];
        if (!photo) {
            $(".text-danger").text("Introduceti o poza cu formatul cerut");
        }
        else {
            var formData = new FormData();

            formData.append("photo", photo);

            $.ajax({
                type: "POST",
                url: Router.action("Gallery", "AddPhoto"),
                data: formData,
                processData: false,
                contentType: false,
                //dataType: "json"
            }).done(function () {
                location.reload();
            })
                .fail(function (a, b, c) {
                    alert("Invalid photo format!");
                });
        }
    });

   

    var source = $("#entry-template").html();
    var template = Handlebars.compile(source);

    $.get(Router.action("Gallery", "GetPhotos"))
        .done(managePhotos)
        .fail(function () {
            alert("ann error has occured");
        });

    function managePhotos(result) {
        for (let i = 0; i < result.length; i++) {
            var picture = '/Gallery/GetPhotoById?id=' + result[i].id + '';
            var photoId = result[i].id;

            var context = { picture: picture, photoId: photoId };
            var html = template(context);

            $('#ExistingPhotos').append(html);

            
        }
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
    }


});