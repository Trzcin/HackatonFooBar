<script lang="ts">
  import type Category from "../types/category";

  export let category: Category = undefined;
  export let color: string;

  function titleCase(str: string) {
    const split = str.toLowerCase().split(' ');
    for (let i = 0; i < split.length; i++) {
      split[i] = split[i].charAt(0).toUpperCase() + split[i].substring(1);
    }
    return split.join(' ');
  }
</script>

<div class="card {color}">
  <h3>{titleCase(category.name)}</h3>
  <div class="times">
    <div>
      <img src="/walk.svg" alt="pieszo" class="transport">
      <p>14 min</p>
    </div>
    <div>
      <img src="/bike.svg" alt="rowerem" class="transport">
      <p>8 min</p>
    </div>
    <div>
      <img src="/bus.svg" alt="transport publiczny" class="transport">
      <p>5 min</p>
    </div>
  </div>
</div>

<style>
  .card {
    flex: 1;
    max-width: 20rem;
    min-width: 20rem;
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

  .transport {
    width: 2rem;
    height: auto;
  }

  .times > div > p {
    margin-top: .5px;
  }
</style>
