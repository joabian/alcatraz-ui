/**
* INSPINIA - Responsive Admin Theme
*
* Inspinia theme use AngularUI Router to manage routing and views
* Each view are defined as state.
* Initial there are written state for all view in theme.
*
*/
function config($stateProvider, $urlRouterProvider, $ocLazyLoadProvider, IdleProvider, KeepaliveProvider) {

    // Configure Idle settings
    IdleProvider.idle(5); // in seconds
    IdleProvider.timeout(120); // in seconds

   $urlRouterProvider.otherwise("/inicio/login");

   /////// $urlRouterProvider.otherwise("/content/ranking");

    $ocLazyLoadProvider.config({
        // Set to true if you want to see what and when is dynamically loaded
        debug: false
    });



    $stateProvider



   




    ////////////inicio login
    .state('inicio', {
        abstract: true,
        url: "/inicio",
        templateUrl: "views/login.html"
    })
        .state('inicio.login', {
            url: "/login",
            //templateUrl: "views/login.html",
            data: { pageTitle: 'Inicio de sesi\u00F3n' },
            resolve: {
                loadPlugin: function ($ocLazyLoad) {
                    return $ocLazyLoad.load([
                        {
                            name: 'angular-peity',
                            files: ['js/plugins/peity/jquery.peity.min.js', 'js/plugins/peity/angular-peity.js']
                        },
                        {
                            files: ['css/plugins/iCheck/custom.css', 'js/plugins/iCheck/icheck.min.js']
                        }
                    ]);
                }
            }
            })

            //////////////////////////fin login


            /////////Olvidaste contraseña

            .state('forgot_password', {
                url: "/forgot_password",
                templateUrl: "views/forgot_password.html",
                data: { pageTitle: 'Cambiar contrasena' },
                resolve: {
                    loadPlugin: function ($ocLazyLoad) {
                        return $ocLazyLoad.load([
                        {
                            name: 'angular-peity',
                            files: ['js/plugins/peity/jquery.peity.min.js', 'js/plugins/peity/angular-peity.js']
                        },
                        {
                            files: ['css/plugins/iCheck/custom.css', 'js/plugins/iCheck/icheck.min.js']
                        }
                    ]);
                    }
                }
            })

            //////////////////fin olvidaste contraseña





            //////////////////ranking

             .state('content', {
                 abstract: true,
                 url: "/content",
                 templateUrl: "views/common/content.html"
             })

            .state('content.ranking', {
                url: "/ranking",
                templateUrl: "views/ranking.htm",
                data: { pageTitle: 'Ranking' },
                resolve: {
                    loadPlugin: function ($ocLazyLoad) {
                        return $ocLazyLoad.load([
                       {
                           serie: true,
                           files: ['js/plugins/dataTables/datatables.min.js', 'css/plugins/dataTables/datatables.min.css']
                       },
                        {
                            serie: true,
                            name: 'datatables',
                            files: ['js/plugins/dataTables/angular-datatables.min.js']
                        },
                        {
                            serie: true,
                            name: 'datatables.buttons',
                            files: ['js/plugins/dataTables/angular-datatables.buttons.min.js']
                        }
                    ]);
                    }
                }
            })

            ////////fin ranking



            ///////Mis comisiones
            
            .state('content.mis_comisiones', {
                url: "/mis_comisiones",
                templateUrl: "views/mis_comisiones.html",
                data: { pageTitle: 'Mis Comisiones' },
                resolve: {
                    loadPlugin: function ($ocLazyLoad) {
                        return $ocLazyLoad.load([
                       {
                           serie: true,
                           files: ['js/plugins/dataTables/datatables.min.js', 'css/plugins/dataTables/datatables.min.css']
                       },
                        {
                            serie: true,
                            name: 'datatables',
                            files: ['js/plugins/dataTables/angular-datatables.min.js']
                        },
                        {
                            serie: true,
                            name: 'datatables.buttons',
                            files: ['js/plugins/dataTables/angular-datatables.buttons.min.js']
                        }
                    ]);
                    }
                }
            })

            //////////fin mis comisiones


            ///////clientes contactados

            .state('content.contactados', {
                url: "/clientes_contactados",
                templateUrl: "views/tabla_contactados.html",
                data: { pageTitle: 'Clientes contactados' },
                resolve: {
                    loadPlugin: function ($ocLazyLoad) {
                        return $ocLazyLoad.load([
                       {
                           serie: true,
                           files: ['js/plugins/dataTables/datatables.min.js', 'css/plugins/dataTables/datatables.min.css']
                       },
                        {
                            serie: true,
                            name: 'datatables',
                            files: ['js/plugins/dataTables/angular-datatables.min.js']
                        },
                        {
                            serie: true,
                            name: 'datatables.buttons',
                            files: ['js/plugins/dataTables/angular-datatables.buttons.min.js']
                        }
                    ]);
                    }
                }
            })

            ////////fin clientes contactados


            //////Clientes por vencer

            .state('content.por_vencer', {
                url: "/clientes_por_vencer",
                templateUrl: "views/tabla_porvencer.html",
                data: { pageTitle: 'Clientes a vencer' },
                resolve: {
                    loadPlugin: function ($ocLazyLoad) {
                        return $ocLazyLoad.load([
                        {
                            serie: true,
                            files: ['js/plugins/dataTables/datatables.min.js', 'css/plugins/dataTables/datatables.min.css']
                        },
                        {
                            serie: true,
                            name: 'datatables',
                            files: ['js/plugins/dataTables/angular-datatables.min.js']
                        },
                        {
                            serie: true,
                            name: 'datatables.buttons',
                            files: ['js/plugins/dataTables/angular-datatables.buttons.min.js']
                        }
                    ]);
                    }
                }
            })

            /////fin clientes por vencer


            /////Clientes vencidos

             .state('content.vencidos', {
                 url: "/clientes_vencidos",
                 templateUrl: "views/tabla_vencidos.html",
                 data: { pageTitle: 'Clientes vencidos' },
                 resolve: {
                     loadPlugin: function ($ocLazyLoad) {
                         return $ocLazyLoad.load([
                        {
                            serie: true,
                            files: ['js/plugins/dataTables/datatables.min.js', 'css/plugins/dataTables/datatables.min.css']
                        },
                        {
                            serie: true,
                            name: 'datatables',
                            files: ['js/plugins/dataTables/angular-datatables.min.js']
                        },
                        {
                            serie: true,
                            name: 'datatables.buttons',
                            files: ['js/plugins/dataTables/angular-datatables.buttons.min.js']
                        }
                    ]);
                     }
                 }
            })

            /////fin clientes vencidos


            ////Nuevo cliente

             .state('content.nuevo_cliente', {
                 url: "/nuevo_cliente",
                 templateUrl: "views/nuevo_cliente.html",
                 data: { pageTitle: 'Nuevo Cliente' },
                 resolve: {
                     loadPlugin: function ($ocLazyLoad) {
                         return $ocLazyLoad.load([
                        {
                            files: ['css/plugins/slick/slick.css', 'css/plugins/slick/slick-theme.css', 'js/plugins/slick/slick.min.js']
                        },
                        {
                            name: 'slick',
                            files: ['js/plugins/slick/angular-slick.min.js']
                        }
                    ]);
                     }
                 }
             })


            /////Cambiar contraseña

            .state('contentCambia', {
                abstract: true,
                url: "/contentCambia",
                templateUrl: "views/common/contentCambiaContra.htm"
            })

            .state('contentCambia.change_password', {
                url: "/change_password",
                templateUrl: "views/change_password.html",
                data: { pageTitle: 'Cambiar contrasena' },
                resolve: {
                    loadPlugin: function ($ocLazyLoad) {
                        return $ocLazyLoad.load([
                        {
                            name: 'angular-peity',
                            files: ['js/plugins/peity/jquery.peity.min.js', 'js/plugins/peity/angular-peity.js']
                        },
                        {
                            files: ['css/plugins/iCheck/custom.css', 'js/plugins/iCheck/icheck.min.js']
                        }
                    ]);
                    }
                }
            })

            ////fin cambiar contraseña


           
        ;

}
angular
    .module('inspinia')
    .config(config)
    .run(function ($rootScope, $state) {
        $rootScope.$state = $state;
    });
