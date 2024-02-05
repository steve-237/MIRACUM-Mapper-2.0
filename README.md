# MIRACUM-Mapper-2.0

![image](https://github.com/steve-237/MIRACUM-Mapper-2.0/assets/88513912/c348493b-11e5-46e3-a679-4ce59d343843)



## Project Description

In this project, our main focus is on creating a dynamic and user-friendly mapping interface powered by ASP.NET Core MVC and C#. The core aim is to simplify the intricate task of mapping real-world data to medical terminologies, classifications, and nomenclatures. By leveraging the flexibility of ASP.NET Core MVC, we aspire to empower users to seamlessly navigate and map diverse datasets encountered in the medical domain. The overarching goal is to tackle the pressing issues of interoperability and data harmonization within the healthcare sector. This involves providing a structured and adaptable solution that not only enhances the consistency and coherence of medical data representation but also promotes seamless integration and exchange of information across different systems and sources. The interface is designed to be intuitive, ensuring that users, regardless of their familiarity with medical terminologies, can efficiently contribute to the mapping process. With ASP.NET Core MVC at its core, the application embodies a robust framework for achieving these objectives, making strides towards a more interconnected and harmonized landscape in medical data management.


## Technological Stack

The technological stack for this application is carefully curated to harness the capabilities of modern tools and frameworks, providing a robust foundation for the development of a flexible and intuitive mapping interface. The key components of our technological stack include:

- **ASP.NET Core MVC:** Serving as the core framework, ASP.NET Core MVC enables the development of a scalable and maintainable web application. Its modular and cross-platform nature ensures compatibility with diverse hosting environments.

- **C#:** The primary programming language, C# is employed for backend logic and business rule implementations. Its strong typing, modern syntax, and integration with the .NET ecosystem contribute to the application's reliability and performance.

- **User Interface Design:** Leveraging the Razor Pages engine and possibly additional frontend technologies like Bootstrap, our user interface design prioritizes an intuitive and responsive user experience. Razor Pages simplify the creation of dynamic and data-driven pages within the ASP.NET Core MVC framework, ensuring a seamless integration with backend logic.

## Cloning the Project with the IDE Microsoft Visual Studio 2022

1. Open Visual Studio:
Launch Microsoft Visual Studio 2022 on your machine.

2. Open the Clone Window:
click on **clone a deposit** below the title start

3. Clone the Project:
In the "clone a deposit" window, paste the GitHub project URL in the provided area, select the location where you want to save the project locally and press "Clone".

## Running the Project with Visual Studio

After opening the application in the IDE (Visual Studio), simply use the keyboard shortcut **crtl + F5** to run the project in no-debug mode, or click directly on the **start** button. Once the project has been run, it will open in the browser. 

## Clone the project and build the Docker Image 

To begin using Docker, start by installing Docker Desktop from the official website and verifying its successful installation. If you're on Windows, ensure that virtualization is enabled in your BIOS settings. The following steps allow you to clone this project locally and create a Docker image of the project, then run it.

1. Open your terminal or command-line interface and run the following command to clone the project repository from GitHub:
```
git clone https://github.com/steve-237/MIRACUM-Mapper-2.0.git
```
2. Change the directory to access the project folder you just cloned:
```
cd MIRACUM-Mapper-2.0
```
3. Use the Docker command to build the image from the Dockerfile. Ensure you are in the project directory where the Dockerfile is located:
```
docker build -t miracum-mapper:2.0 .
```
4. Start a container based on the image you just built. You can specify the ports according to your requirements:
```
docker run -p 8080:80 -p 443:443 miracum-mapper:2.0
```
5. Open a web browser and go to the following address:
```
http://localhost:8080
```
