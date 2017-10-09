(function () {

	"use strict"

	tasklistApp.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);

	tasklistApp.run(function (timerCheckoutFactory, $interval, $rootScope, $state) {
		timerCheckoutFactory.startTimer();
	});

	tasklistApp
		.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', '$httpProvider', '$compileProvider', function ($stateProvider, $urlRouterProvider, $locationProvider, $httpProvider, $compileProvider) {

			var baseUrl = $("base").first().attr("href");
			$urlRouterProvider.otherwise("home");
			// Remove a hashtag da URL.
			$locationProvider.html5Mode(true);

			// Desabilita o debug
			$compileProvider.debugInfoEnabled(false);

			$stateProvider.state('home', {
				url: '/home',
				templateUrl: baseUrl + 'Content/views/home.html'
			});

			// Erros
			$httpProvider.interceptors.push('AuthHttpResponseInterceptor');
		}]);
})();