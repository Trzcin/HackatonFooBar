<script lang="ts">
  import type Category from "../types/category";
  import CategoryCard from "./CategoryCard.svelte";
  export let data: Category[] = [];
</script>

<main>
  {#each data as category }
    <CategoryCard {category} />
  {/each} 
</main>

<style>
  main {
    display: grid;
    margin: 5rem auto 5rem auto;
    grid-template-columns: 1fr 1fr 1fr;
    gap: 3rem;
    width: fit-content;
  }  
</style>
