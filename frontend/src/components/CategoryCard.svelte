<script lang="ts">
  import type Category from "../types/category";

  export let category: Category = undefined;
  export let color: string;
</script>

<div class="card {color}">
  <h3>{category.name}</h3>
  <p>Apteka Novum</p>
  <div class="times">
    <div>
      <p>pieszo</p>
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
</style>
