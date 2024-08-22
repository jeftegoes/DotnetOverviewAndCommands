function onSendData() {
    var FieldA = $("#fieldA").val();
    var FieldB = $("#fieldB").val();
    var File = $('#file')[0].files[0];
    
    var fdata = new FormData();

    fdata.append("FieldA", FieldA);
    fdata.append("FieldB", FieldB);
    fdata.append("File", File);

    $.ajax({
        type: "POST",
        url: "api/UploadFile",
        data: fdata,
        processData: false,
        contentType: false,
        success: function (data) {
          alert("Dados enviados com sucesso!", data);
        },
        error: function(data) {
            console.log(data);
            alert("Erro ao enviar os dados: " + data.responseText)
        }
    });
}

$(document).ready(function () {

});
