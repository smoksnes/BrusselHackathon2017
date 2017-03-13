﻿angular.module('hackDirectives').directive('animateOnChange', function ($animate, $timeout) {
    return function (scope, elem, attr) {
        scope.$watch(attr.animateOnChange, function (nv, ov) {
            if (nv != ov) {
                var c = nv > ov ? 'change-up' : 'change';
                $animate.addClass(elem, c).then(function () {
                    $timeout(function () { $animate.removeClass(elem, c); });
                });
            }
        });
    };
});