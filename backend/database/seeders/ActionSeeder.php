<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class ActionSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table("actions")->insert([
            'action'=> 'sleep',
        ]);
      
        DB::table("actions")->insert([
            'action'=> 'eat',
        ]);
        
        DB::table("actions")->insert([
            'action'=> 'hunt',
        ]);
       
        DB::table("actions")->insert([
            'action'=> 'walk',
        ]);
    }
}
