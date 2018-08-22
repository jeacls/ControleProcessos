angular.module("DicasRapidas").factory("fab", function ($q, $http) {
    return {
        listar: function () {
            var promessa = $q.defer();

            $http.get("https://meus-filmes-874c2.firebaseio.com/filmes.json").then(
                function (result) {
                    console.log(result);
                }
            );

            return promessa.promise;
        }
    };
});