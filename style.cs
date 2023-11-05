
* {
    box-sizing: border-box;
    padding: 0;
    margin: 0;
    font-family: Inter, -apple-system, BlinkMacSystemFont, 'Segoe UI', 'Open Sans';
    
  }
  
  ::placeholder {
    color: rgb(221, 221, 221);
  }
  
  .wrapper {
    height: 100vh;
    width: 100%;
    display: flex;
    justify-content: center;
    flex-direction: column;
    align-items: center;
    background-color: rgb(20, 19, 19);
    transition: 0.8s all;
  }
  
  h1 {
    margin-bottom: 1.5%;
    color: #fff;
    font-weight: normal;
  }
  
  .container {
    width: 350px;
    display: flex;
    justify-content: center;
    flex-direction: column;
    align-items: center;
  }
  
  .header-container {
    display: flex;
    justify-content: space-between;
    align-items: center;
    width: 80%;
  }
  
  .top-buttons {
    display: flex;
    align-items: center;
  
  }
  
  input {
    padding: 25px;
    color: rgb(255, 255, 255);
    font-size: 1em;
    cursor: pointer;
    width: 70px;
    background-color: rgb(47, 51, 50);
    border: none;
    outline: none;
    border-radius: 100px;
    margin: 0.2em;
  }
  
  .first-row,
  .second-row,
  .third-row,
  .fourth-row,
  .fifth-row {
    margin-bottom: 4px;
  }
  
  input[type="text"] {
    background-color: rgb(47, 51, 50);
    width: 222.5px;
  }
  
  
  #clear-button {
    color: #fff;
    background-color: rgb(255, 42, 42);
  }
  
  a {
    text-decoration: none;
    color: #fff;
  }
  
  