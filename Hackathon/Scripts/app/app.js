var hackApp = angular.module('hackServices', []);
var hackApp = angular.module('hackDirectives', []);
var hackApp = angular.module('hackCtrls', ['hackServices']);
var hackApp = angular.module('hackApp', ['hackCtrls', 'hackServices', 'hackDirectives', 'ui.materialize', 'ngTouch', 'ngAnimate']);