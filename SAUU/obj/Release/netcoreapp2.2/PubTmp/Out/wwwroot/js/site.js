var _validFileExtensions = [".jpg", ".jpeg", ".bmp", ".gif", ".png"];
function removeImg(thisEl, imgID) {
    var imgElement = $('#' + imgID);
    if (thisEl.is(':checked')) {
        imgElement.attr("data-originalSrc", imgElement.attr("src"));
        imgElement.attr("src", "/img/no_image2.jpg");
    } else {
        imgElement.attr("src", imgElement.attr("data-originalSrc"));
    }
}


function showpreview(input) {
    if (validarExtension(input)) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                $('#imgAvatar').css('visibility', 'visible');
                $('#imgAvatar').attr('src', e.target.result);
            };
            reader.readAsDataURL(input.files[0]);
        }
    }
}

function validarExtension(oInput) {
    if (oInput.type == "file") {
        var sFileName = oInput.value;
        if (sFileName.length > 0) {
            var blnValid = false;
            for (var j = 0; j < _validFileExtensions.length; j++) {
                var sCurExtension = _validFileExtensions[j];
                if (sFileName.substr(sFileName.length - sCurExtension.length, sCurExtension.length).toLowerCase() == sCurExtension.toLowerCase()) {
                    blnValid = true;
                    break;
                }
            }

            if (!blnValid) {
                alert("El archivo adjunto contiene una extensión no valida!. Extensiones permitidas: " + _validFileExtensions.join(", "));
                oInput.value = "";
                return false;
            }
        }
    }
    return true;
}

//Cargar Pueblos
function cargarPueblos(ciuId, classSelect) {
    if (ciuId === 0) return;
    $.ajax({
        url: "/pueblos/GetJson?ciuId=" + ciuId,
        success: function (result) {
            select = $(classSelect);
            select.empty();
            select.append($('<option>', {
                text: "- Seleccione -"
            }));
            if (result.length > 0) {
                $.each(result, function (i, item) {
                    select.append($('<option>', {
                        value: item.pueId,
                        text: item.pueDescripcion
                    }));
                    select.removeAttr("disabled");
                });
            } else {
                select.attr("disabled", true);
            }
        }
    });
}

function dateDiffYear (birthday) {
    var now = new Date();
    var past = new Date(birthday);
    var nowYear = now.getFullYear();
    var pastYear = past.getFullYear();
    var age = nowYear - pastYear;

    return age;
}

$(document).ready(function () {
    //DATA TABLE

    $('#tableJs').dataTable({
        scrollX: true,
        language: {
            "lengthMenu": "Mostrar _MENU_ registros por pagina.",
            "zeroRecords": "No se encontraron registros!.",
            "info": "Pagina _PAGE_ / _PAGES_",
            "infoEmpty": "No se encontraron registros!.",
            "infoFiltered": " Total Registros: _MAX_",
            "decimal": ".",
            "search" : "respondido",
            "thousands": ",",
            "paginate": {
                "previous": "«",
                "next": "»"
            }
        },
        columnDefs: [
            { "targets": [0], "searchable": false },
            { "targets": [0], "orderable": false }
        ]
    });


    $(function (){
        var message = $("#_message").val();
        if (message.length > 0) {
            if (message.includes("Error")) {
                $.growl.error({ message: message, title: "SAUU - Alertas" });
            } else {
                $.growl.notice({ message: message, title: "SAUU - Alertas" });
            }

        }
    });

    $(".ajaxDelete").click(function (e) {
        e.preventDefault();
        var id = $(this).attr("data-id");
        var display = $(this).attr("data-display");
        //var action = $(this).attr("data-action");
        var modal = $("#modalDelete");

        if (modal.length) {
            modal.find("#id").val(id.split('|')[0]);
            if (id.split('|').length > 1) {
                modal.find("#id2").val(id.split('|')[1]);
            }

            modal.find(".display b").html(display);
            //modal.find("form").attr("action", action);
            modal.modal('show');
        }
    });
});
