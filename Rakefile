task :default => :stage

desc "Build app"
task :build do
	sh "xbuild Nancy.Simple.sln"
end

desc "Deploy to Heroku"
task :deploy => :build do
	sh "git push heroku master"
end

desc "Stage locally"
task :stage => :build do
	sh "foreman start local"
end
