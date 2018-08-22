var app = angular.module("DicasRapidas").factory("DicasAPI", function ($http) {
    console.log("vai deletar");
    var _ListarDicas = function () {
        return $http.get("http://localhost:10708/api/Dica/ListarDicas");
    };

    var _Incluir = function (oDica) {
        return $http.post("http://localhost:10708/api/Dica/Incluir", oDica)
    };

    var _Deletar = function (DicaID) {
        console.log(DicaID);
        return $http.post("http://localhost:10708/api/Dica/Excluir?lDicaID=" + DicaID);
    };

    var _MostrarPoupap = function () {

    };

    return {

        ListarDicas: _ListarDicas,
        Incluir : _Incluir,
        Deletar: _Deletar,
        MostrarPoupap: _MostrarPoupap
    };
});