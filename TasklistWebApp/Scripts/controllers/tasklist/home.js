(function () {

	"use strict"

	tasklistApp
		// =========================================================================
		// Base controller for common functions
		// =========================================================================
		.controller('tasklistCtrl',
			function($timeout, $state, $scope, $rootScope, $http) {

				// Saudação usuário.      
				//this.saudacaoUsuario = function() {
				//	$http.post(urlAction('Saudacao', 'Conta')).success(function(data) {
				//		$scope.nomeUsuario = data.nome;
				//		$scope.nomeCompletoUsuario = data.nomeCompleto;
				//		$scope.LocalImagem = data.localFotoPerfil;
				//		if ($scope.nomeUsuario) {
				//			growlService.growl('Bem vindo, ' + $scope.nomeUsuario + '!', 'inverse');
				//		}
				//	});
				//}

				// Chamada dos métodos após autênticação.
				//this.saudacaoUsuario();
			});

})();