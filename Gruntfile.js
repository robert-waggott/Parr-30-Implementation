module.exports = function(grunt) {
	grunt.initConfig({
	    shell: {
	    	runUnitTests: {
	    		command: "mono packages/Machine.Specifications.Runner.Console.0.9.2/tools/mspec.exe PARR30.UnitTests/bin/Debug/PARR30.UnitTests.dll"
	    	}
	    },

		watch: {
			dlls: {
				files: ['**/*.dll'],
				tasks: ['shell:runUnitTests'],
				options: {
					spawn: false
				}
			}
		}
	});

	grunt.loadNpmTasks('grunt-contrib-watch');
	grunt.loadNpmTasks('grunt-shell');

	grunt.registerTask('default', ['watch:dlls']);
};