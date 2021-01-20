# Introduction 
TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project. 

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Build and Test
docker build -t devops:v1 .
docker images
docker run -it --rm -p 8080:80 devops:v1
docker ps
docker kill <containerID>
docker rm <containerID>

# Contribute# Introduction
Implement [marufaytekin/hello-world](https://github.com/marufaytekin/hello-world) 

# Getting Started
1.	Install Docker
2.	Install Visual Studio Code
3.	Install C# Extension
4.	Install Docker Extension
5.	Optional: Install PowerShell Extension
Note: Tested on Windows 10

# Build and Test

1. git clone https://github.com/softwarepronto/devopsportal.git
2. Run Visual Studio Code
3. From Visual Studio Code invoke menu File | Open folder and select cloned git repository (folder devopsportal)
4. From Visual Studio, Run | Start Debugging (this will run the build task)
5. Run URL from browser: http://localhost:8080/
6. Run URL from browser:  http://localhost:8080/healthz
7. Run URL from browser (Open API): http://localhost:8080/swagger
8. From Visual Studio, invoke menu Run | Stop Debugging 
9. Display Visual Studio Code's Terminal window (View | Terminal)
10. Build container: docker build -t devops:v1 .
11. Run service: docker run -it --rm -p 8080:80 devops:v1
12. Run URL from browser: http://localhost:8080/
13. Run URL from browser: http://localhost:8080/healthz
