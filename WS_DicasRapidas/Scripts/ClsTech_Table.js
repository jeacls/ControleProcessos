$(function () {
            $('#tblPlano tbody tr td').dblclick(function () {
                var conteudoOriginal = $(this).text();
                
                console.log($(this).attr("id"));

                $(this).addClass("celulaEmEdicao");

                if ($(this).attr("id") == "dtCadastro") {
                    $(this).html("<input type='date' value='" + conteudoOriginal + "' />");
                }
                else {
                    $(this).html("<input type='text' value='" + conteudoOriginal + "' />");
                }
                $(this).children().first().focus();

                $(this).children().first().keypress(function (e) {
                    if (e.which == 13) {
                        var novoConteudo = $(this).val();
                        $(this).parent().text(novoConteudo);
                        $(this).parent().removeClass("celulaEmEdicao");
                    }
                });

                $(this).children().first().blur(function () {
                    $(this).parent().text(conteudoOriginal);
                    $(this).parent().removeClass("celulaEmEdicao");
                });
               
            });
        });