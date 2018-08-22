
var app = angular.module("DicasRapidas").factory("LoginAPI", function ($http) {
    var _Validar = function (login, senha) {
        var data = { "DsLogin": login, "DsSenha":senha }
        return $http.post("/api/login/Logar", data);
    };


    return {
        Validar: _Validar
    };
});
