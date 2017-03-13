var hackApp = angular.module('hackServices', []);
var hackApp = angular.module('hackCtrls', ['hackServices']);
var hackApp = angular.module('hackApp', ['hackCtrls', 'hackServices', 'ui.materialize', 'ngTouch']);