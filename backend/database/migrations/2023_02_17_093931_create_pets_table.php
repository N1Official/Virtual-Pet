<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('pets', function (Blueprint $table) {
            $table->id();
            $table->string("name");
            $table->string("type");
            $table->integer("hunger");
            $table->integer("thirst");
            $table->string("mood");
            $table->integer("speed");
            $table->integer("health");
            $table->integer("skill");
            $table->integer("age");
            $table->string("age_group");
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('pets');
    }
};
