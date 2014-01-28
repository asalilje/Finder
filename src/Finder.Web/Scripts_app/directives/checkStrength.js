finderApp.directive('checkStrength', function() {
    return {
        restrict: 'A',
        link: function (scope, elem, attrs) {
            var strength = {
                strengths: ['Dålig', 'Hyfsad', 'Bra', 'Suverän', 'FRA-säkert'],

                measureStrength: function (p) {

                    var _force = 0;
                    var _regex = /[$-/:-?{-~!"^_`\[\]]/g;

                    var _lowerLetters = /[a-z]+/.test(p);
                    var _upperLetters = /[A-Z]+/.test(p);
                    var _numbers = /[0-9]+/.test(p);
                    var _symbols = _regex.test(p);

                    var _flags = [_lowerLetters, _upperLetters, _numbers, _symbols];
                    var _passedMatches = _flags.filter(function(el) { return el === true; }).length;

                    _force += 2 * p.length + ((p.length >= 10) ? 1 : 0);
                    _force += _passedMatches * 10;

                    // penalty (short password)
                    _force = (p.length <= 6) ? Math.min(_force, 10) : _force;

                    // penalty (poor variety of characters)
                    _force = (_passedMatches == 1) ? Math.min(_force, 10) : _force;
                    _force = (_passedMatches == 2) ? Math.min(_force, 20) : _force;
                    _force = (_passedMatches == 3) ? Math.min(_force, 40) : _force;

                    return _force;

                },
                getStrength: function(s) {
                    var idx = 0;
                    if (s <= 10) { idx = 0; }
                    else if (s <= 20) { idx = 1; }
                    else if (s <= 30) { idx = 2; }
                    else if (s <= 40) { idx = 3; }
                    else { idx = 4; }

                    return this.strengths[idx];
                },
            };

            scope.$watch(attrs.checkStrength, function () {
                if (scope.newuser.password === '') {
                    elem.css({ "display": "none" });
                } else {
                    var str = strength.getStrength(strength.measureStrength(scope.newuser.password));
                    elem.css({ "display": "inline" });
                    elem.text(str);
                }
            });

        },
    };
});