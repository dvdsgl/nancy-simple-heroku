Demo project for hosting Nancy and Mono on Heroku
=================================================

Build locally
-------------
Before deploying your source code you will need to ensure that it builds locally. For example:

	$ xbuild Nancy.Demo.Hosting.Self.sln

Procfile
--------
Web specifies the command Heroku executes to start the application. The path to Mono should not be changed, this is specified within the Buildpack.

To test running your application locally, execute the following:

	$ foreman start local
  
