
const wrapper= document.querySelector('.wrapper');
const login=document.querySelector('.login-link');
const registerLink=document.querySelector('.register-link');
const Close=document.querySelector('.icon-close');

registerLink.addEventListener('click',()=>{
    wrapper.classList.add('active')
});

login.addEventListener('click',()=>{
    wrapper.classList.remove('active')
})

Close.addEventListener('click',()=>{
    wrapper.style.display='none';
})

let register=document.querySelector('.btnRegister')
register.addEventListener('click',()=>{
    wrapper.style.display='flex';
    wrapper.classList.add('active')
})

let signin=document.querySelector('.btnLogin')
signin.addEventListener('click',()=>{
    wrapper.classList.remove('active')
    wrapper.style.display='flex';
  
})

let dugme=document.querySelector('.btnR')
dugme.addEventListener('click',()=>{
    let input=document.querySelector('#user').value
    document.querySelector('.dobodosli').innerHTML="Dobrodosli:"+input;
    wrapper.style.display='none';

   
    
})

