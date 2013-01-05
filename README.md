# Simple Nancy App

A bare-bones, self-hosting Nancy app with instructions for Heroku deployment.
All of the heavy lifting was done by [Ben Hall](https://github.com/BenHall); the
goal of this fork is simply to collect and document Ben's hard work to make
simple C# apps on Heroku easier to create.

## Setup Dependencies

```shell
$ # Get RVM (Ruby Version Manager)
$ curl -L https://get.rvm.io | bash -s stable --ruby
$ # Load RVM
$ source ~/.rvm/scripts/rvm
$ # Install Heroku and other Ruby dependencies
$ bundle install
```

## Creating a New Heroku App

```shell
$ heroku create --stack cedar --buildpack http://github.com/BenHall/heroku-buildpack-mono
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
