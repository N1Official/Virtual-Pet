<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class PetSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        //tiger
        DB::table("pets")->insert([
            'name'=>'tiger',
            'type' =>'null',
            'hunger'=>0,
            'thirst'=>0,
            'mood'=>'null',
            'speed'=>0,
            'health'=>0,
            'skill'=>0,
            'age'=>0,
            'age_group'=>'null',
        ]);

        //panther
        DB::table("pets")->insert([
            'name'=>'panther',
            'type' =>'null',
            'hunger'=>0,
            'thirst'=>0,
            'mood'=>'null',
            'speed'=>0,
            'health'=>0,
            'skill'=>0,
            'age'=>0,
            'age_group'=>'null',
        ]);

        //lion
        DB::table("pets")->insert([
            'name'=>'lion',
            'type' =>'null',
            'hunger'=>0,
            'thirst'=>0,
            'mood'=>'null',
            'speed'=>0,
            'health'=>0,
            'skill'=>0,
            'age'=>0,
            'age_group'=>'null',
        ]);

        //snake
        DB::table("pets")->insert([
            'name'=>'snake',
            'type' =>'null',
            'hunger'=>0,
            'thirst'=>0,
            'mood'=>'null',
            'speed'=>0,
            'health'=>0,
            'skill'=>0,
            'age'=>0,
            'age_group'=>'null',
        ]);

        //dog
        DB::table("pets")->insert([
            'name'=>'dog',
            'type' =>'null',
            'hunger'=>0,
            'thirst'=>0,
            'mood'=>'null',
            'speed'=>0,
            'health'=>0,
            'skill'=>0,
            'age'=>0,
            'age_group'=>'null',
        ]);

        //cat
        DB::table("pets")->insert([
            'name'=>'cat',
            'type' =>'null',
            'hunger'=>0,
            'thirst'=>0,
            'mood'=>'null',
            'speed'=>0,
            'health'=>0,
            'skill'=>0,
            'age'=>0,
            'age_group'=>'null',
        ]);

        //hamster
        DB::table("pets")->insert([
            'name'=>'hamster',
            'type' =>'null',
            'hunger'=>0,
            'thirst'=>0,
            'mood'=>'null',
            'speed'=>0,
            'health'=>0,
            'skill'=>0,
            'age'=>0,
            'age_group'=>'null',
        ]);
       
    }
}
