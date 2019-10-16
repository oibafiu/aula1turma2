
function funcao() {

    var nome = $('input[name="nome"]').val();

    alert("Que premio o que " + nome +  " seu bundão");

}
$('#myModal').on('shown.bs.modal', function () {
    $('#myInput').trigger('focus')
});

function k(i) {
    var v = i.value.replace(/\D/g, '');
    v = (v / 100).toFixed(2) + '';
    v = v.replace(".", ",");
    v = v.replace(/(\d)(\d{3})(\d{3}),/g, "$1.$2.$3,");
    v = v.replace(/(\d)(\d{3}),/g, "$1.$2,");
    i.value = v;
}
function converter() {

    valor = parseFloat(document.getElementById("real").value);
  
    var dolarAmericano = 4.16;

    var opcao = document.getElementById("opções").value;
    switch (opcao){
        case "Dolar":
            document.getElementById("valorFinal").innerHTML = (valor / dolarAmericano).toFixed(2);
            break;
        
        
    }
}
