# Simple Nancy App

A bare-bones, self-hosting Nancy app with instructions for Heroku deployment.
All of the heavy lifting was done by [Ben Hall](https://github.com/BenHall); the
goal of this fork is simply to collect and document Ben's hard work to make
simple C# apps on Heroku easier to create.

## Setup Dependencies

Create a Heroku account, then do the following to install Heroku tools
and login to your Heroku account:

```shell
$ # Install Homebrew (package manager that installs heroku tools)
$ ruby -e "$(curl -fsSkL raw.github.com/mxcl/homebrew/go)"
$ # Install Heroku Toolbelt
$ brew install heroku-toolbelt
$ # Create symlinks to heroku tools
$ sudo brew link heroku-toolbelt
$ heroku login
```

## Creating a New Heroku App

When you create a new Heroku app, Heroku automatically assigns you a
hostname for your app. In the example below, the hostname is
`stark-hollows-8350.herokuapp.com`. You need to save this hostname in an
environment variable named `HOST` for the Nancy app to bind to the
correct Uri; *do not* just copy-paste the source below–you must specify
your unique host.

```shell
$ heroku create --stack cedar --buildpack http://github.com/BenHall/heroku-buildpack-mono
$ heroku config:set HOST=stark-hollows-8350.herokuapp.com
$ git push heroku master
```

## Building Locally

Before deploying your source code you will need to ensure that it builds locally. For example:

```shell
$ xbuild Nancy.Demo.Hosting.Self.sln
```

## Running Locally

To test running your application locally, execute the following:

```shell
$ foreman start local
```
