var Cachorrinho = { nome: "" , idade: "", raca: ""}

$(document).ready(

    function () {
        $('input[name="nome"]').val(Cachorrinho.nome);
        $('input[name="raca"]').val(Cachorrinho.raca);
        $('input[name="idade"]').val(Cachorrinho.idade);
        $('input[name="raca"]').val(Cachorrinho.cor);

        $('input[name="salvar"]').click(function () {
            Cachorrinho.nome = ('input[name="nome"]').val();
            Cachorrinho.idade = ('input[name="idade"]').val();
            Cachorrinho.raca = ('input[name="raca"]').val();
            Cachorrinho.raca = ('input[name="cor"]').val();

        });
        $('input[name="mostrar"]').click(function () {
            alert("Nome" + Cachorinho.nome + "Idade:" + Cachorrinho.idade);
        });
    }
);

function LimparTela() {
    var meusInputs = $('input[type="text"]');

    for (var i = 0; i < meusInputs.length; i++) {
        meusInputs.val("");
    }
}
