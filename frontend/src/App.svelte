<script lang="ts">
  import Router from 'svelte-spa-router';
  import Search from './routes/Search.svelte';

  const routes = {
    '/': Search
  };
</script>

<Router {routes}/>
