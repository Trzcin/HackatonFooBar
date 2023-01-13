<script lang="ts">
  import type Category from "../types/category";

  export let category: Category = undefined;
  export let color: string;
</script>

<div class="card {color}">
  <h3>{category.name}</h3>
  {#if category.link}
    <a href="{category.link}">
      <p>Apteka Novum</p>
      <img src="eye.svg" alt="zobacz" id="eye">
    </a> 
  {:else}
    <p>Apteka Novum</p>
  {/if}
  <div class="times">
    <div>
      <img src="" alt="">
      <p>14 min</p>
    </div>
    <div>
      <p>rowerem</p>
      <p>14 min</p>
    </div>
    <div>
      <p>tramwajem</p>
      <p>14 min</p>
    </div>
  </div>
</div>

<style>
  .card {
    width: 100%;
    border-radius: 5px;
    color: white;
    padding: 1rem 2rem;
  }

  .times {
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
    gap: 1.5rem;
    margin-top: 2rem;
  }

  .times * {
    text-align: center;
  }

  .card > p {
    margin-top: .5rem;
  }

  #eye {
    width: 1.5rem;
    height: auto;
  }

  a {
    color: white;
    margin-top: .5rem;
    display: flex;
    gap: .5rem;
    align-items: center;
  }
</style>
