
const form = document.getElementById("form");
const username = document.getElementById("username");
const email = document.getElementById("email");
const cep = document.getElementById("cep");
const cpf = document.getElementById("cpf");
const cnpj = document.getElementById("cnpj");
const endereco = document.getElementById("endereco");



form.addEventListener("submit", (event) => {
    event.preventDefault();
    
    checkForm();

})

function checkInputUsername(){
    const usernameValue = username.value;

    	if(usernameValue === ""){
            erroInput(username, "Preencha o nome do usuário!")
        }
        else{
            const formItem = username.parentElement;
            formItem.className = "form_content"
        }
}

function checkInputEmail(){
    const emailValue = email.value;

    	if(emailValue === ""){
            erroInput(email, "E-mail obrigatório.")
        }
        else{
            const formItem = email.parentElement;
            formItem.className = "form_content"
        }
}

function habilitarInput(id) {
    const input = document.getElementById(id);
    input.disabled = !input.disabled;    

}
function checkInputCep(){
    const cepValue = cep.value;
    
    if (cepValue === ""){
        erroInput(cep, "Por favor digitar o CEP corretamente.")
    }
    else if(!value.match(/^\d+$/)){
        erroInput(cep, "Preencha o cep corretamente")
    }
    else{
        const formItem = cep.parentElement;
        formItem.className = "form_content"
    }
    
}
function checkInputEndereco(){
    const enderecoValue = endereco.value;

    	if(enderecoValue === ""){
            erroInput(endereco, "Preencha o endereço corretamente")
        }
        else{
            const formItem = endereco.parentElement;
            formItem.className = "form_content"
        }
}

function checkForm(){
    
    checkInputUsername();
    checkInputEmail();    
    checkInputCep();
    checkInputEndereco();
  
    const formItems = form.querySelectorAll(".form_content")
  
    const isValid = [...formItems].every( (item) => {
      return item.className === "form_content"
    });
  
    if(isValid){
      alert("CADASTRADO COM SUCESSO!")
    }
  
  }

function erroInput(input, message){

    const formItem = input.parentElement;
    const textMessage = formItem.querySelector("a")

   textMessage.innerText = message;

   formItem.className = "form_content error"
}






