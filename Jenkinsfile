pipeline {
  agent any
    
    
  stages {
        
    stage('Cloning Git') {
      steps {
        git 'https://github.com/sarah-nmachi/hello.git'
      } 
     
    }
    stage('Build') {
       steps {
         sh '''
         dotnet build
         '''
       }
    }
        
   
  }
}
