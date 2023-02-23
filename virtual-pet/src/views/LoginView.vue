<template>
    <div class="login">
        <form @submit.prevent="login">
            <input type="email" id="email" v-model="userData.email" placeholder="Email">
            <input type="password" v-model="userData.password" placeholder="Jelszó">
            <button type="submit">Bejelentkezés</button>
        </form>
    </div>
</template>

<script setup>
import {reactive,ref} from 'vue';
import {useRouter} from "vue-router";

const router = useRouter();

const userData = reactive({
    email: '',
    password: ''
});

// const error = ref(null);

// async function login(){
//     const response = await http.post('login', userData);
//     if(response.status !== 200){
//         error.value = response.statusText
//     }else{
//         localStorage.setItem('token',response.data.data.token);
//         router.push({name: 'index'});
//     }
// }
</script>