<script lang="ts">
  import type {Group} from "../groups";

  export let groups: Group[];
</script>

<div id="ratings">
  {#each groups as group}
    <div class="rating">
      <img src="/group_icons/{group.icon}" alt="ikona grupy">
      <h3>{group.name}</h3>
      <p>65%</p> 
    </div>    
  {/each}
</div>

<style>
  #ratings {
    display: flex;
    align-items: center;
    margin: 2rem 1.5rem 0 1.5rem;
  }

  .rating {
    flex: 1;
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  .rating:not(:last-child) {
    border-right: 2px solid #007bff;
  }

  img {
    width: 6rem;
    height: auto;
  }

  p {
    margin-top: .5rem;
    font-size: 3rem;
  }
</style>
