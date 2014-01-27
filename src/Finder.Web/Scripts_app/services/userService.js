
finderModule.service("userService", [
    "$http", "$q", function($http, $q) {

        var _registerUser = function(newUser) {

            var deferred = $q.defer();

            $http.post("/register", newUser)
                .then(function(result) {
                        var user = result.data;
                        deferred.resolve(user);
                    },
                    function(result) {
                        deferred.reject(result.data);
                    });

            return deferred.promise;
        };

        return {
            registerUser: _registerUser
        };
    }
]);
