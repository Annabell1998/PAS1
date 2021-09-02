jQuery(document).ready(function ($) {
    $('#txtUsuario').focus();
    $('#btnEntrar').on('click', function () {
        if ($('#txtUsuario').val() != "" & $('#txtPass').val() != "") {
            Validate($('#txtUsuario').val(), $("txtPass").val());
        }
        else {
            Swal.fire(
                'Error',
                'Favor de ingresar usuario y clave',
                'error'
            );
        }
    });

    function Validate(email, password) {
        var record = {
            Email: email,
            Password: password
        };

        $.ajax({
            url: '/Usuario/GetUsuarios',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) { },
            complete: function (data) {
                if (data.status == true) {
                    window.location.href = '/Home/Index';
                }
                else if (data.status == false) {
                    Swal.fire(
                        'Error',
                        data.message,
                        'error'
                    );
                }
            },
            error: function (data) {
                Swal.fire(
                    'Error',
                    data.message,
                    'error'
                );
            }
        });
    };

});