/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
    // Full Project configuration. in INITCONFIG
    grunt.initConfig({
        //name mention in preload task below
        concat: {
            //name whatever u like, dist for distribution 
            js: {
                //source of js & css files- mention files names here, follow the path syntax
                src: ['Static/js/try-bundling.js', 'Static/js/try-bundling2.js'],
                //more popular name to store is build
                dest: 'build/js/scripts.js',
            },
            css: {
                //source of js & css files- mention files names here
                src: ['Static/css/try-bundling.css', 'Static/css/try-bundling2.css'],
                //more popular name to store is build
                dest: 'build/css/styles.css',
            },
        },
        watch: {
            js: {
                files: ['**/*.js'], //if anything changes in any folder in any .js file
                tasks: ['concat'], // .... then concatinate them
            },
            css: {
                files: ['**/*.css'],
                tasks: ['concat'],
            },
        },
    });

    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.registerTask('default', ['concat', 'watch']);
};