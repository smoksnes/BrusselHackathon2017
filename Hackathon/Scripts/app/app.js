var hackApp = angular.module('hackServices', []);
var hackApp = angular.module('hackCtrls', ['hackServices']);
var hackApp = angular.module('hackApp', ['hackCtrls', 'hackServices', 'ui.materialize', 'ngTouch']);


//    .config([
//    'hammerDefaultOptsProvider', function (hammerDefaultOptsProvider) {
//        debugger;
//        hammerDefaultOptsProvider.set({
//            recognizers: [[Hammer.Swipe, { time: 250 }]]
//        });
//    }
//]);