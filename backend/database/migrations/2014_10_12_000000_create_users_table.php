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
        Schema::create('users', function (Blueprint $table) {
            $table->id();
	    $table->string("pid");
            $table->string("username");
            $table->string("email");
            $table->string("password");
            $table->string("firstName");
            $table->string("lastName");
            $table->string("gender");
            $table->date("birthday");
            $table->string("phone");
            $table->string("address");
            $table->string("city");
            $table->string("state");
            $table->integer("zipcode");
            $table->string("country");
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('users');
    }
};