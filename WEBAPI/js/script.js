$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var cep = $('input[name="cep"]').mask("99999-999")

                if (cep.val() == "")
                    alert("VOC� N�O DIGITOU NENHUM CEP");

                else
                {
                    $.get("https://viacep.com.br/ws/" + $('input[name="cep"]').mask("99999-999").val() + "/json/", function (data, status) {

                        if (data.erro) {
                            alert("CEP INVALIDO")
                        }
                       
                        $('input[name="bairro"]').val(data.bairro), $('input[name="localidade"]').val(data.localidade), $('input[name="cep"]').mask("99999-999"), $('input[name="logradouro"]').val(data.logradouro);
                    });
                }
                }
        );
    }
);


//$(document).ready(function () {

//    function limpa_formul�rio_cep() {
//        // Limpa valores do formul�rio de cep.
//        $("#rua").val("");
//        $("#bairro").val("");
//        $("#cidade").val("");
//        $("#uf").val("");
//        $("#ibge").val("");
//    }

//    //Quando o campo cep perde o foco.
//    $("#cep").click(function () {

//        //Nova vari�vel "cep" somente com d�gitos.
//        var cep = $(this).val().replace(/\D/g, '');

//        //Verifica se campo cep possui valor informado.
//        if (cep != "") {

//            //Express�o regular para validar o CEP.
//            var validacep = /^[0-9]{8}$/;

//            //Valida o formato do CEP.
//            if (validacep.test(cep)) {

//                //Preenche os campos com "..." enquanto consulta webservice.
//                $("#rua").val("...");
//                $("#bairro").val("...");
//                $("#cidade").val("...");
//                $("#uf").val("...");
//                $("#ibge").val("...");

//                //Consulta o webservice viacep.com.br/
//                $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

//                    if (!("erro" in dados)) {
//                        //Atualiza os campos com os valores da consulta.
//                        $("#rua").val(dados.logradouro);
//                        $("#bairro").val(dados.bairro);
//                        $("#cidade").val(dados.localidade); 
//                        $("#uf").val(dados.uf);
//                        $("#ibge").val(dados.ibge);
//                    } //end if.
//                    else {
//                        //CEP pesquisado n�o foi encontrado.
//                        limpa_formul�rio_cep();
//                        alert("CEP n�o encontrado.");
//                    }
//                });
//            } //end if.
//            else {
//                //cep � inv�lido.
//                limpa_formul�rio_cep();
//                alert("Formato de CEP inv�lido.");
//            }
//        } //end if.
//        else {
//            //cep sem valor, limpa formul�rio.
//            limpa_formul�rio_cep();
//        }
//    });
//});

