<?php

namespace App\Http\Controllers;

use App\Models\Mood;
use App\Http\Resources\MoodResource;
use App\Http\Requests\StoreMoodRequest;
use Illuminate\Http\Request;

class MoodController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $moods = Mood::all();
        return MoodResource::collection($moods);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  App\Http\Requests\StoreMoodRequest  $request
     * @return \Illuminate\Http\Response
     */
    public function store(StoreMoodRequest $request)
    {
        $data = $request->validated();
        $newMood = Mood::create($data);
        return new MoodResource($newMood);
    }


    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($mood)
    {
        $moods = Mood::findOrFail($mood);
        $moods->delete();
    }
}
