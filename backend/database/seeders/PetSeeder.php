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
            'type' =>'tiger',
            'hunger'=>10,
            'thirst'=>10,
            'mood'=>'Lonely',
            'speed'=>100,
            'health'=>100,
            'skill'=>10,
            'age'=>0,
            'age_group'=>'Kölyök',
        ]);

        //panther
        DB::table("pets")->insert([
            'name'=>'panther',
            'type' =>'panther',
            'hunger'=>10,
            'thirst'=>10,
            'mood'=>'Lonely',
            'speed'=>100,
            'health'=>100,
            'skill'=>10,
            'age'=>0,
            'age_group'=>'Kölyök',
        ]);

        //lion
        DB::table("pets")->insert([
            'name'=>'lion',
            'type' =>'lion',
            'hunger'=>10,
            'thirst'=>10,
            'mood'=>'Lonely',
            'speed'=>100,
            'health'=>100,
            'skill'=>10,
            'age'=>0,
            'age_group'=>'Kölyök',
        ]);

        //snake
        DB::table("pets")->insert([
            'name'=>'snake',
            'type' =>'snake',
            'hunger'=>10,
            'thirst'=>10,
            'mood'=>'Lonely',
            'speed'=>100,
            'health'=>100,
            'skill'=>10,
            'age'=>0,
            'age_group'=>'Kölyök',
        ]);

        //dog
        DB::table("pets")->insert([
            'name'=>'dog',
            'type' =>'dog',
            'hunger'=>10,
            'thirst'=>10,
            'mood'=>'Lonely',
            'speed'=>100,
            'health'=>100,
            'skill'=>10,
            'age'=>0,
            'age_group'=>'Kölyök',
        ]);

        //cat
        DB::table("pets")->insert([
            'name'=>'cat',
            'type' =>'cat',
            'hunger'=>10,
            'thirst'=>10,
            'mood'=>'Lonely',
            'speed'=>100,
            'health'=>100,
            'skill'=>10,
            'age'=>0,
            'age_group'=>'Kölyök',
        ]);

        //hamster
        DB::table("pets")->insert([
            'name'=>'hamster',
            'type' =>'hamster',
            'hunger'=>10,
            'thirst'=>10,
            'mood'=>'Lonely',
            'speed'=>100,
            'health'=>100,
            'skill'=>10,
            'age'=>0,
            'age_group'=>'Kölyök',
        ]);
       
    }
}
