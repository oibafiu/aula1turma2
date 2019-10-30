$(document).ready(function () {
    //PEGAR A INFORMAÇÃO DO BOTÃO E ENVIAR OS DADOS PARA A URL
    $('button[id="calcular"]').click(function () {
        //VARIAVEIS QUE VAMOS PEGAR DO INDEX

       
        var informacoesEmFormatoJSON = $('#FormularioLegal').serializeArray();
        

        var url2 = "http://localhost:56503/Api/CalculoImc";
        $.post(url2, informacoesEmFormatoJSON, function (data) {
            
            alert("IMC: " +  data);
        });
    });
});