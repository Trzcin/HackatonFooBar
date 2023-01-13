<script lang="ts">
  import type Category from "../types/category";
  import CategoryCard from "./CategoryCard.svelte";
  export let data: Category[] = [];

  const colors = ['blue', 'teal', 'green', 'yellow', 'red'];
</script>

<main>
  <h2>Najbliższe punkty z kategorii</h2>
  <div id="grid">
    {#each data as category }
      <CategoryCard {category} color={colors[Math.floor(Math.random() * colors.length)]}/>
    {/each}
  </div>
</main>

<style>
  main {
    margin: 3rem 1.5rem 3rem 1.5rem;
  }

  #grid {
    margin-top: 2rem;
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
    gap: 2rem;
    width: fit-content;
  }
</style>
