(function () {
    'use strict';

    angular
        .module('app')
        .controller('README', README);

    README.$inject = ['$location'];

    function README($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'README';

        activate();

        function activate() { }
    }
})();
