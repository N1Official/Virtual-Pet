<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class PettypeSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table("pettype")->insert([
            'pettype'=> 'tiger',
        ]);
      
        DB::table("pettype")->insert([
            'pettype'=> 'panther',
        ]);
        
        DB::table("pettype")->insert([
            'pettype'=> 'lion',
        ]);
       
        DB::table("pettype")->insert([
            'pettype'=> 'snake',
        ]);

        DB::table("pettype")->insert([
            'pettype'=> 'dog',
        ]);

        DB::table("pettype")->insert([
            'pettype'=> 'cat',
        ]);

        DB::table("pettype")->insert([
            'pettype'=> 'hamster',
        ]);
    }
}
