<script setup>
import { RouterLink, RouterView } from 'vue-router'
</script>

<template>
  <div class="head">
    <RouterLink to="/">Gondozás</RouterLink>
    <RouterLink to="/hunt">Vadászat</RouterLink>
    <RouterLink to="/game">Játék</RouterLink>
    <RouterLink to="/doctor">Orvos</RouterLink>
  </div>

  <RouterView />
</template>